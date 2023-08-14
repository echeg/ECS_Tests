using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System275 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component2> _p1;
EcsPool<Component463> _p2;
EcsPool<Component206> _p3;
EcsPool<Component488> _p4;
EcsPool<Component32> _pl0;
 public void Init (IEcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component2>().Inc<Component463>().Inc<Component206>().Inc<Component488>().End();
   _p1 = _world.GetPool<Component2>();
   _p2 = _world.GetPool<Component463>();
   _p3 = _world.GetPool<Component206>();
   _p4 = _world.GetPool<Component488>();
   _pl0 = _world.GetPool<Component32>();
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
