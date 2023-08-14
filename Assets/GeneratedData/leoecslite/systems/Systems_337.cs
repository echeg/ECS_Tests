using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System337 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component330> _p1;
EcsPool<Component477> _p2;
EcsPool<Component479> _p3;
EcsPool<Component437> _pl0;
 public void Init (IEcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component330>().Inc<Component477>().Inc<Component479>().End();
   _p1 = _world.GetPool<Component330>();
   _p2 = _world.GetPool<Component477>();
   _p3 = _world.GetPool<Component479>();
   _pl0 = _world.GetPool<Component437>();
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
