using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System182 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component408> _p1;
EcsPool<Component12> _p2;
EcsPool<Component157> _p3;
EcsPool<Component224> _pl0;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component408>().Inc<Component12>().Inc<Component157>().End();
   _p1 = _world.GetPool<Component408>();
   _p2 = _world.GetPool<Component12>();
   _p3 = _world.GetPool<Component157>();
   _pl0 = _world.GetPool<Component224>();
 }
 public void Run (EcsSystems systems) {
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
