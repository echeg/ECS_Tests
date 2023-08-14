using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System348 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component70> _p1;
EcsPool<Component22> _p2;
EcsPool<Component386> _p3;
EcsPool<Component332> _pl0;
 public void Init (IEcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component70>().Inc<Component22>().Inc<Component386>().End();
   _p1 = _world.GetPool<Component70>();
   _p2 = _world.GetPool<Component22>();
   _p3 = _world.GetPool<Component386>();
   _pl0 = _world.GetPool<Component332>();
 }
 public void Run (IEcsSystems systems) {
  foreach (int entity in _filter) {
   if (_p1.Has(entity))
   {
    _p1.Del(entity);
   }
   else
   {
    _p1.Add(entity);
   }
  }
 }
}

}
