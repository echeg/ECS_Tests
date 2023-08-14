using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System331 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component448> _p1;
EcsPool<Component414> _p2;
EcsPool<Component185> _p3;
EcsPool<Component290> _pl0;
 public void Init (IEcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component448>().Inc<Component414>().Inc<Component185>().End();
   _p1 = _world.GetPool<Component448>();
   _p2 = _world.GetPool<Component414>();
   _p3 = _world.GetPool<Component185>();
   _pl0 = _world.GetPool<Component290>();
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
