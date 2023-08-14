using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System240 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component241> _p1;
EcsPool<Component164> _p2;
EcsPool<Component151> _p3;
EcsPool<Component305> _pl0;
 public void Init (IEcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component241>().Inc<Component164>().Inc<Component151>().End();
   _p1 = _world.GetPool<Component241>();
   _p2 = _world.GetPool<Component164>();
   _p3 = _world.GetPool<Component151>();
   _pl0 = _world.GetPool<Component305>();
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
