using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System126 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component73> _p1;
EcsPool<Component191> _p2;
EcsPool<Component68> _p3;
EcsPool<Component176> _p4;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component73>().Inc<Component191>().Inc<Component68>().Inc<Component176>().End();
   _p1 = _world.GetPool<Component73>();
   _p2 = _world.GetPool<Component191>();
   _p3 = _world.GetPool<Component68>();
   _p4 = _world.GetPool<Component176>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  var q = 0;
  }
 }
}

}
