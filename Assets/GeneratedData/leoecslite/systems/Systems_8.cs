using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System8 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component218> _p1;
EcsPool<Component27> _p2;
EcsPool<Component157> _p3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component218>().Inc<Component27>().Inc<Component157>().End();
   _p1 = _world.GetPool<Component218>();
   _p2 = _world.GetPool<Component27>();
   _p3 = _world.GetPool<Component157>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   component1.Field0 += 1;
  }
 }
}

}
