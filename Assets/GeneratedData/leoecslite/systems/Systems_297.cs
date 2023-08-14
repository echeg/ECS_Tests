using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System297 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component476> _p1;
EcsPool<Component151> _p2;
EcsPool<Component20> _p3;
EcsPool<Component408> _pl0;
 public void Init (IEcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component476>().Inc<Component151>().Inc<Component20>().End();
   _p1 = _world.GetPool<Component476>();
   _p2 = _world.GetPool<Component151>();
   _p3 = _world.GetPool<Component20>();
   _pl0 = _world.GetPool<Component408>();
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
