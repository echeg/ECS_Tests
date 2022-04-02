using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System137 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component135> _p1;
EcsPool<Component243> _p2;
EcsPool<Component119> _p3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component135>().Inc<Component243>().Inc<Component119>().End();
   _p1 = _world.GetPool<Component135>();
   _p2 = _world.GetPool<Component243>();
   _p3 = _world.GetPool<Component119>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  var q = 0;
  }
 }
}

}
