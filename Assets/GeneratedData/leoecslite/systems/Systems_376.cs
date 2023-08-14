using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System376 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component12> _p1;
EcsPool<Component315> _p2;
EcsPool<Component253> _p3;
EcsPool<Component467> _pl0;
 public void Init (IEcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component12>().Inc<Component315>().Inc<Component253>().End();
   _p1 = _world.GetPool<Component12>();
   _p2 = _world.GetPool<Component315>();
   _p3 = _world.GetPool<Component253>();
   _pl0 = _world.GetPool<Component467>();
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
